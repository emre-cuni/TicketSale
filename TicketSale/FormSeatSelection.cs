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
                foreach (Control control in panelSeatSelection.Controls)
                {
                    PictureBox pictureBoxControl;
                    try
                    {
                        pictureBoxControl = (PictureBox)control;
                        if (pictureBoxControl.Name == selectedSeatName)
                        {
                            if ((pictureBoxControl.Name.LastIndexOf("A") >= 11 || pictureBoxControl.Name.LastIndexOf("F") >= 11) && (pictureBoxControl.Name.LastIndexOf("15") == -1 && pictureBoxControl.Name.LastIndexOf("16") == -1))
                                pictureBoxControl.Image = imageListSeats.Images[0];
                            else if ((pictureBoxControl.Name.LastIndexOf("B") >= 11 || pictureBoxControl.Name.LastIndexOf("E") >= 11) && (pictureBoxControl.Name.LastIndexOf("15") == -1 && pictureBoxControl.Name.LastIndexOf("16") == -1))
                                pictureBoxControl.Image = imageListSeats.Images[1];
                            else if ((pictureBoxControl.Name.LastIndexOf("C") >= 11 || pictureBoxControl.Name.LastIndexOf("D") >= 11) && (pictureBoxControl.Name.LastIndexOf("15") == -1 && pictureBoxControl.Name.LastIndexOf("16") == -1))
                                pictureBoxControl.Image = imageListSeats.Images[2];
                            else
                                pictureBoxControl.Image = imageListSeats.Images[3];
                            pictureBoxControl.Image.Tag = false;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }

                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox.Image.Tag != null && !(bool)pictureBox.Image.Tag)
                {
                    pictureBox.Image = imageListSeats.Images[6];
                    pictureBox.Image.Tag = true;
                    selectedSeatName = pictureBox.Name;
                    selectedSeatCount++;
                }
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
                pictureBox.Image.Tag = false;
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
