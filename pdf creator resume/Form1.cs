using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;


namespace pdf_creator_resume
{
    public partial class _frmPDFgenerator : Form
    {
        private readonly string json_filepath = @"C:\Users\arriane\source\repos\pdf creator resume\json file\jsonInfo.JSON";

        public _frmPDFgenerator()
        {
            InitializeComponent();
        }

        private void _btnJSON_Click(object sender, EventArgs e)
        {
            _frmJSON openform = new _frmJSON();
            openform.Show();
        }

        public class ResumeContent
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Github { get; set; }
            public string Facebook { get; set; }
            public string Message { get; set; }
            public string SoftSkill_1 { get; set; }
            public string SoftSkill_2 { get; set; }
            public string SoftSkill_3 { get; set; }
            public string SoftSkill_4 { get; set; }
            public string SoftSkill_5 { get; set; }
            public string HardSkill_1 { get; set; }
            public string HardSkill_2 { get; set; }
            public string HardSkill_3 { get; set; }
            public string HardSkill_4 { get; set; }
            public string HardSkill_5 { get; set; }
            public string WorkExperience_1 { get; set; }
            public string WorkExperience_2 { get; set; }
            public string WorkExperience_3 { get; set; }
            public string WorkExperience_4 { get; set; }
            public string WorkExperience_5 { get; set; }
            public string ContactNumber { get; set; }
            public string Email { get; set; }
    
        }

        private void _btnGenerate_Click(object sender, EventArgs e)
        {
            string jsonFile;
            using (var reader = new StreamReader(json_filepath))
            {
                jsonFile = reader.ReadToEnd();
            }
            var Resume = JsonConvert.DeserializeObject<ResumeContent>(jsonFile);

            //Name, Address and Contact number
            string Name = Resume.Name;
            string Address = Resume.Address;
            string ContactNumber = Resume.ContactNumber;


            //Contacts
            string Email = Resume.Email;
            string Github = Resume.Github;
            string Facebook = Resume.Facebook;

            //Introduction
            string Message = Resume.Message;

            //Soft Skills
            string SoftSkill_1 = Resume.SoftSkill_1;
            string SoftSkill_2 = Resume.SoftSkill_2;
            string SoftSkill_3 = Resume.SoftSkill_3;
            string SoftSkill_4 = Resume.SoftSkill_4;

            //Hard Skills
            string HardSkill_1 = Resume.HardSkill_1;
            string HardSkill_2 = Resume.HardSkill_2;
            string HardSkill_3 = Resume.HardSkill_3;
            string HardSkill_4 = Resume.HardSkill_4;

            //Work Experience
            string WorkExperience_1 = Resume.WorkExperience_1;
            string WorkExperience_2 = Resume.WorkExperience_2;
            string WorkExperience_3 = Resume.WorkExperience_3;
            string WorkExperience_4 = Resume.WorkExperience_4;

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.InitialDirectory = @"C:\Users\arriane\source\repos\pdf creator resume\pdf file";
                saveFile.FileName = Name + ".pdf";
                saveFile.Filter = "PDF|*.pdf";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = Name + " " + "Resume";
                    PdfPage page = pdf.AddPage();

                    XGraphics graphics = XGraphics.FromPdfPage(page);

                    XFont leftcontent = new XFont(" ", 18, XFontStyle.Bold);
                    XFont rightcontent = new XFont(" ", 16, XFontStyle.Bold);
                    XFont fontcontent = new XFont(" ", 12, XFontStyle.Regular);
                    XFont BigFont = new XFont(" ", 18, XFontStyle.Bold);

                    graphics.DrawRectangle(XBrushes.DimGray, 0, 0, page.Width.Point, page.Height.Point);
                    graphics.DrawRectangle(XBrushes.DarkGray, 200, 0, page.Width.Point, page.Height.Point);

                    int leftinitial = 200;

                    int middlemargin = 220;
                    int middleinitial = 200;

                    //Name
                    graphics.DrawString(Name, BigFont, XBrushes.Black, new XRect(11, 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //Contacts
                    graphics.DrawString("Contacts", leftcontent, XBrushes.Black, new XRect(11, leftinitial + 35, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(Address, fontcontent, XBrushes.Black, new XRect(11, leftinitial + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(ContactNumber, fontcontent, XBrushes.Black, new XRect(11, leftinitial + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(Email, fontcontent, XBrushes.Black, new XRect(11, leftinitial + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(Github, fontcontent, XBrushes.Black, new XRect(11, leftinitial + 105, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //Soft Skills
                    graphics.DrawString("Soft Skills", rightcontent, XBrushes.Black, new XRect(middlemargin, 500, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(SoftSkill_1, fontcontent, XBrushes.Black, new XRect(middlemargin, 520, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(SoftSkill_2, fontcontent, XBrushes.Black, new XRect(middlemargin, 540, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(SoftSkill_3, fontcontent, XBrushes.Black, new XRect(middlemargin, 560, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(SoftSkill_4, fontcontent, XBrushes.Black, new XRect(middlemargin, 580, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //Hard Skills
                    graphics.DrawString("Hard Skills", rightcontent, XBrushes.Black, new XRect(middlemargin, 360, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(HardSkill_1, fontcontent, XBrushes.Black, new XRect(middlemargin, 390, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(HardSkill_2, fontcontent, XBrushes.Black, new XRect(middlemargin, 410, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(HardSkill_3, fontcontent, XBrushes.Black, new XRect(middlemargin, 430, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(HardSkill_4, fontcontent, XBrushes.Black, new XRect(middlemargin, 450, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //line
                    graphics.DrawRectangle(XBrushes.WhiteSmoke, middlemargin, middleinitial - 10, 350, 2);

                    //Work Experience
                    graphics.DrawString("Work Experience", rightcontent, XBrushes.Black, new XRect(middlemargin, 210, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(WorkExperience_1, fontcontent, XBrushes.Black, new XRect(middlemargin, 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(WorkExperience_2, fontcontent, XBrushes.Black, new XRect(middlemargin, 260, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(WorkExperience_3, fontcontent, XBrushes.Black, new XRect(middlemargin, 280, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graphics.DrawString(WorkExperience_4, fontcontent, XBrushes.Black, new XRect(middlemargin, 300, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //line
                    graphics.DrawRectangle(XBrushes.WhiteSmoke, middlemargin, 340, 350, 2);

                    //Picture
                    string pic = @"C:\Users\arriane\source\repos\pdf creator resume\pdf file\mypic.jfif";
                    XImage image = XImage.FromFile(pic);
                    graphics.DrawImage(image, 400, 20, 150, 150);

                    pdf.Save(saveFile.FileName);
                    MessageBox.Show("Thanks for using this application");
                    this.Close();

                }

        }    }

    }
}
