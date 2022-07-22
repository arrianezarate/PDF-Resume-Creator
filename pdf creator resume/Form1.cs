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
            
            
        }

    }
}
