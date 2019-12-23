using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrolleybus
{
    public partial class FormBusStation : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelStation station;

        FormBusConfig form;

        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        private Logger logger;
        public FormBusStation()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            station = new MultiLevelStation(countLevel, pictureBoxStation.Width, pictureBoxStation.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxStation.Width, pictureBoxStation.Height);
                Graphics gr = Graphics.FromImage(bmp);
                station[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxStation.Image = bmp;
            }
        }

        //take
        private void buttonTakeBus_Click(object sender, EventArgs e)
        {

            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")

                {
                    try

                    {
                        
                        var bus = station[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
                        if (bus != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                           pictureBoxTakeBus.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            bus.SetPosition(5, 5, pictureBoxTakeBus.Width,
                           pictureBoxTakeBus.Height);
                            bus.DrawBus(gr);
                            pictureBoxTakeBus.Image = bmp;
                        }
                        else
                        {
                            Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                           pictureBoxTakeBus.Height);
                            pictureBoxTakeBus.Image = bmp;
                        }
                        Draw();
                    }
                    catch (BusStationNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                       pictureBoxTakeBus.Height);
                        pictureBoxTakeBus.Image = bmp;
                        logger.Error("Не найдено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetBus_Click_1(object sender, EventArgs e)
        {
            form = new FormBusConfig();
            form.AddEvent(AddBus);
            form.Show();
        }

        private void AddBus(ITransport bus)
        {
            if (bus != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = station[listBoxLevels.SelectedIndex] + bus;
                    logger.Info("Добавлен автобус " + bus.ToString() + " на место " + place);
                    Draw();
                }
                catch (BusStationOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
            }
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try

                {
                    station.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
            }
        }

            private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try

                {
                    station.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (BusStationOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Занятое место");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
                Draw();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            station.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
