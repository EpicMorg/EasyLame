using emg.donation.library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLame
{
    public partial class FrmMain : Form
    {
        //
        // Global strings
        //
        string AppId = "EasyLame";
        int AppPostponedDays = 7;

        string lameExe = "lame.exe";
        bool found = false;
        string systemPath = Environment.GetEnvironmentVariable("PATH");
        string lamePath;

        public FrmMain()
        {
            InitializeComponent();
            DonationStartup.ShowOnce(AppId, Convert.ToInt32(AppPostponedDays));
            LameCheck();
        }
        private void LameCheck()
        {
            foreach (string path in systemPath.Split(Path.PathSeparator))
            {
                string fullPath = Path.Combine(path, lameExe);
                if (File.Exists(fullPath))
                {
                    found = true;
                    lamePath = fullPath;
                    break;
                }
            }

            // Если не найдено в системном пути, проверяем рядом с программой
            if (!found)
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localPath = Path.Combine(appDirectory, lameExe);
                if (File.Exists(localPath))
                {
                    found = true;
                    lamePath = localPath;
                }
            }

            // Если lame.exe не найден нигде, показываем сообщение
            if (!found)
            {
                toolStripStatusLabelLameBool.Text = "NOT Found";
                toolStripStatusLabelLameBool.ForeColor = Color.DarkRed;
                buttonBrowse.Enabled = true;
                groupBox.Enabled = false;
            }
            else
            {
                textBoxLamePath.Text = lamePath;
                toolStripStatusLabelLameBool.Text = "Found";
                toolStripStatusLabelLameBool.ForeColor = Color.DarkGreen;
                buttonBrowse.Enabled = false;
                groupBox.Enabled = true;

            }
        }

        private async void RunLameProcess(string inputWavPath, string outputMp3Path)
        {
            try
            {
                // Создаем процесс для запуска lame.exe
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = lamePath,
                    Arguments = $"-b 320 \"{inputWavPath}\" \"{outputMp3Path}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8, // Указываем кодировку
                    StandardErrorEncoding = Encoding.UTF8
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;

                    // Подписываемся на события вывода
                    process.OutputDataReceived += (sender, e) => LogMessage(e.Data);
                    process.ErrorDataReceived += (sender, e) => LogMessage(e.Data);

                    // Запускаем процесс
                    process.Start();

                    // Начинаем асинхронное чтение вывода
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    // Асинхронно ждем завершения процесса
                    await Task.Run(() => process.WaitForExit());

                    // Проверяем результат выполнения
                    if (process.ExitCode == 0)
                    {
                        LogMessage($"Конвертация файла {Path.GetFileName(inputWavPath)} завершена успешно!");
                    }
                    else
                    {
                        LogMessage($"Ошибка при конвертации файла {Path.GetFileName(inputWavPath)}.");
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Ошибка: {ex.Message}");
            }
        }

        private void LogMessage(string message)
        {
            // Выводим сообщение в TextBox
            if (!string.IsNullOrEmpty(message))
            {
                textBoxLog.Invoke((MethodInvoker)delegate
                {
                    textBoxLog.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelDropToConvert_Click(object sender, EventArgs e)
        {
            // 1. Открываем диалог выбора WAV-файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WAV Files (*.wav)|*.wav";
                openFileDialog.Title = "Выберите WAV-файл";
                openFileDialog.Multiselect = true; // Разрешаем выбор нескольких файлов

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Обрабатываем каждый выбранный файл
                    foreach (string inputWavPath in openFileDialog.FileNames)
                    {
                        // 2. Открываем диалог сохранения MP3-файла
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
                            saveFileDialog.Title = "Сохранить MP3-файл";
                            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(inputWavPath) + ".mp3";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string outputMp3Path = saveFileDialog.FileName;

                                // 3. Запускаем процесс lame.exe
                                RunLameProcess(inputWavPath, outputMp3Path);
                            }
                        }
                    }
                }
            }
        }

        private void panelDropToConvert_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что перетаскиваемый объект - это файл
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // Разрешаем копирование
            }
            else
            {
                e.Effect = DragDropEffects.None; // Запрещаем, если это не файл
            }
        }

        private void panelDropToConvert_DragDrop(object sender, DragEventArgs e)
        {
            // Получаем список перетащенных файлов
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Обрабатываем каждый файл
            foreach (string inputWavPath in files)
            {
                // Проверяем, что файл имеет расширение .wav
                if (Path.GetExtension(inputWavPath).ToLower() == ".wav")
                {
                    // Открываем диалог сохранения MP3-файла
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
                        saveFileDialog.Title = "Сохранить MP3-файл";
                        saveFileDialog.FileName = Path.GetFileNameWithoutExtension(inputWavPath) + ".mp3";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string outputMp3Path = saveFileDialog.FileName;

                            // Запускаем процесс lame.exe
                            RunLameProcess(inputWavPath, outputMp3Path);
                        }
                    }
                }
                else
                {
                    LogMessage($"Файл {Path.GetFileName(inputWavPath)} не является WAV-файлом.");
                }
            }
        }
    }
}
