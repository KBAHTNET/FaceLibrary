using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceDetectionAndRecognition_By_IlyaBratskih
{
    public partial class ChoseDetectRegion : Form
    {

        public static int chosenRegion = 0;

        public ChoseDetectRegion()
        {
            InitializeComponent();
            for(int i=0;i< MainForm.ForChoseDetectRegions.Count;i++)
            {
                ChosenRegionsList.Items.Add(i.ToString());
            }
        }

        private void ChoseDetectRegion_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.ForChoseDetectRegions.Clear();
            MainForm.ForChoseDetectRegions = new List<Image<Bgr, byte>>();
        }

        private void Chose_Click(object sender, EventArgs e)
        {
            chosenRegion = ChosenRegionsList.FocusedItem.Index;
            this.Close();
        }

        private void ChosenRegionsList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            PreviewRegion.Image = MainForm.ForChoseDetectRegions[ChosenRegionsList.FocusedItem.Index];
        }
    }
}
