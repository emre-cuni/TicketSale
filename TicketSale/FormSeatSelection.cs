using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSale
{
    public partial class FormSeatSelection : Form
    {
        public FormSeatSelection(int _passengerCount)
        {
            InitializeComponent();
            passengerCount = _passengerCount;
        }

        PictureBox pictureBox;
        Label label;
        int x1 = 89, x2 = 95, labelSize = 16, passengerCount, selectedSeatCount = 0;
        string selectedSeatName = null;

        private void FormSeatSelection_Load(object sender, EventArgs e)
        {
            try
            {
                AddSeat();

                // Acil Çıkış koltuklarını düzenle

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Koltuk Seçimi Load Hatası");
            }
        }

        private void SeatSelection_Click(object sender, EventArgs e)
        {
            try
            {
                //AddSeat();

                PictureBox pictureBox = (PictureBox)sender;
                //if(selectedSeatName == null)
                //{
                //    foreach (var item in panelSeatSelection.Controls)
                //    {
                //        panelSeatSelection.Controls.Find()

                //    }
                //}

                /*
                    1 defa koltuk seçtikten sonra aynı ekranda koltuğu değiştirmeyi ekle
                 */

                if (pictureBox.Image != imageListSeats.Images[6] && selectedSeatCount < passengerCount)
                {
                    pictureBox.Image = imageListSeats.Images[6];
                    selectedSeatName = pictureBox.Name;
                    selectedSeatCount++;
                }
                MessageBox.Show(selectedSeatCount + "\n" + pictureBox.Name);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Koltuk Seçimi Hatası");
            }
        }

        private void AddLabel(string text, int x, int y, int size)
        {
            try
            {
                label = new Label();
                label.Text = text;
                label.Location = new Point(x, y);
                label.Size = new Size(size, 18);
                label.Name = "label" + text;
                panelSeatSelection.Controls.Add(label);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Label Ekleme Hatası");
            }
        }

        private void AddSeatPicture(string name, int x, int y, int imageIndex)
        {
            try
            {
                pictureBox = new PictureBox();
                pictureBox.Size = new Size(25, 25);
                pictureBox.Name = name;//$"pictureBox{i}B";
                pictureBox.Image = imageListSeats.Images[imageIndex];
                pictureBox.Location = new Point(x, y);
                pictureBox.Click += SeatSelection_Click;
                panelSeatSelection.Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Resim Ekleme Hatası");
            }
        }

        private void AddSeat()
        {
            try
            {
                panelSeatSelection.Controls.Clear();

                x1 = 89;
                x2 = 95;
                labelSize = 16;

                AddLabel("A", 36, 52, 17);
                AddLabel("B", 36, 85, 17);
                AddLabel("C", 36, 118, 17);
                AddLabel("D", 36, 175, 17);
                AddLabel("E", 36, 208, 17);
                AddLabel("F", 36, 241, 17);

                for (int i = 1; i <= 32; i++)
                {
                    if (i > 9)
                        labelSize = 24;

                    AddLabel(i.ToString(), x2, 147, labelSize);
                    //label = new Label();
                    //label.Text = i.ToString();
                    //label.Location = new Point(x2, 147);
                    //label.Size = new Size(labelSize, 18);
                    //label.Name = $"label{i}";
                    //panelSeatSelection.Controls.Add(label);

                    if (i == 15 || i == 16)
                    {
                        AddSeatPicture($"pictureBox{i}A", x1, 45, 3);
                        AddSeatPicture($"pictureBox{i}B", x1, 78, 3);
                        AddSeatPicture($"pictureBox{i}C", x1, 111, 3);
                        AddSeatPicture($"pictureBox{i}D", x1, 175, 3);
                        AddSeatPicture($"pictureBox{i}E", x1, 208, 3);
                        AddSeatPicture($"pictureBox{i}F", x1, 241, 3);
                    }
                    else
                    {
                        AddSeatPicture($"pictureBox{i}A", x1, 45, 0);
                        AddSeatPicture($"pictureBox{i}B", x1, 78, 1);
                        AddSeatPicture($"pictureBox{i}C", x1, 111, 2);
                        AddSeatPicture($"pictureBox{i}D", x1, 175, 2);
                        AddSeatPicture($"pictureBox{i}E", x1, 208, 1);
                        AddSeatPicture($"pictureBox{i}F", x1, 241, 0);
                    }

                    {
                        //pictureBox = new PictureBox();
                        //pictureBox.Size = new Size(25, 25);
                        //pictureBox.Name = $"pictureBox{i}A";
                        //pictureBox.Image = imageListSeats.Images[0];
                        //pictureBox.Location = new Point(x1, 45);
                        //pictureBox.Tag = $"pictureBox{i}A";
                        //pictureBox.Click += SeatSelection_Click;
                        //panelSeatSelection.Controls.Add(pictureBox);

                        //pictureBox = new PictureBox();
                        //pictureBox.Size = new Size(25, 25);
                        //pictureBox.Name = $"pictureBox{i}B";
                        //pictureBox.Image = imageListSeats.Images[1];
                        //pictureBox.Location = new Point(x1, 78);
                        //pictureBox.Click += SeatSelection_Click;
                        //panelSeatSelection.Controls.Add(pictureBox);

                        //pictureBox = new PictureBox();
                        //pictureBox.Size = new Size(25, 25);
                        //pictureBox.Name = $"pictureBox{i}C";
                        //pictureBox.Image = imageListSeats.Images[2];
                        //pictureBox.Location = new Point(x1, 111);
                        //pictureBox.Click += SeatSelection_Click;
                        //panelSeatSelection.Controls.Add(pictureBox);

                        //pictureBox = new PictureBox();
                        //pictureBox.Size = new Size(25, 25);
                        //pictureBox.Name = $"pictureBox{i}D";
                        //pictureBox.Image = imageListSeats.Images[2];
                        //pictureBox.Location = new Point(x1, 175);
                        //pictureBox.Click += SeatSelection_Click;
                        //panelSeatSelection.Controls.Add(pictureBox);

                        //pictureBox = new PictureBox();
                        //pictureBox.Size = new Size(25, 25);
                        //pictureBox.Name = $"pictureBox{i}E";
                        //pictureBox.Image = imageListSeats.Images[1];
                        //pictureBox.Location = new Point(x1, 208);
                        //pictureBox.Click += SeatSelection_Click;
                        //panelSeatSelection.Controls.Add(pictureBox);

                        //pictureBox = new PictureBox();
                        //pictureBox.Size = new Size(25, 25);
                        //pictureBox.Name = $"pictureBox{i}F";
                        //pictureBox.Image = imageListSeats.Images[0];
                        //pictureBox.Location = new Point(x1, 241);
                        //pictureBox.Click += SeatSelection_Click;
                        //panelSeatSelection.Controls.Add(pictureBox);
                    }

                    x1 += 33;
                    if (i == 9)
                        x2 += 30;
                    else
                        x2 += 33;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Koltuk Ekleme Hatası");
            }
        }
    }
}
