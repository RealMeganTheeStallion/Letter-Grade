using static System.Formats.Asn1.AsnWriter;

namespace Calculate_Letter_Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(txtNumberGrade.Text);
            if (score > 90)
                txtLetterGrade.Text = "A";
            else if (score > 80)
                txtLetterGrade.Text = "B";
            else if (score > 70)
                txtLetterGrade.Text = "C";
            else if (score > 60)
                txtLetterGrade.Text = "D";
            else
                txtLetterGrade.Text = "F";
        }


       
          
    }
}