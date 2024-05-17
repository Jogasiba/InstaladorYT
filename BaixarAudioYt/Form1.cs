using System;
using System.Linq;
using System.Windows.Forms;
using YoutubeExplode;

namespace YoutubeAudioDownloader
{
    public partial class MainForm : Form
    {
        private readonly YoutubeClient _youtubeClient;

        public MainForm()
        {
            InitializeComponent();
            _youtubeClient = new YoutubeClient();
            status.Text = "";
        }
        private async void btnDownload_Click_1(object sender, EventArgs e)
        {
            try
            {
                var videoUrl = txtVideoUrl.Text.Trim();

                if (string.IsNullOrWhiteSpace(videoUrl))
                {
                    MessageBox.Show("Por favor, insira a URL do vídeo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                status.Text = "Convertendo áudio e baixando... Aguarde!";

                var video = await _youtubeClient.Videos.GetAsync(videoUrl);
                var streamInfo = await _youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                var audioStreamInfo = streamInfo.GetAudioStreams().OrderByDescending(s => s.Bitrate).FirstOrDefault();

                if (audioStreamInfo == null)
                {
                    MessageBox.Show("Não foi possível encontrar um stream de áudio para este vídeo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var saveFileDialog = new SaveFileDialog
                {
                    FileName = $"{video.Title}.mp3",
                    Filter = "Arquivos MP3|*.mp3",
                    Title = "Salvar Áudio"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var outputPath = saveFileDialog.FileName;
                    await _youtubeClient.Videos.Streams.DownloadAsync(audioStreamInfo, outputPath);
                    status.Text = "";
                    MessageBox.Show($"Áudio baixado com sucesso como: {outputPath}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonVideo_Click(object sender, EventArgs e)
        {
            try
            {
                var videoUrl = txtVideoUrl.Text.Trim();

                if (string.IsNullOrWhiteSpace(videoUrl))
                {
                    MessageBox.Show("Por favor, insira a URL do vídeo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var video = await _youtubeClient.Videos.GetAsync(videoUrl);
                var streamInfo = await _youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                var videoStreamInfo = streamInfo.GetVideoStreams().OrderByDescending(s => s.VideoQuality).FirstOrDefault();

                if (videoStreamInfo == null)
                {
                    MessageBox.Show("Não foi possível encontrar um stream de vídeo para este vídeo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var saveFileDialog = new SaveFileDialog
                {
                    FileName = $"{video.Title}.{videoStreamInfo.Container.Name}",
                    Filter = $"{videoStreamInfo.Container.Name.ToUpper()} Files|*.{videoStreamInfo.Container.Name}",
                    Title = "Salvar Vídeo"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var outputPath = saveFileDialog.FileName;
                    await _youtubeClient.Videos.Streams.DownloadAsync(videoStreamInfo, outputPath);
                    MessageBox.Show($"Vídeo baixado com sucesso como: {outputPath}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
