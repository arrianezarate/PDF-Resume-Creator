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


namespace pdf_creator_resume
{
    public partial class _frmPDFgenerator : Form
    {
        private readonly string filepath = @"C:\Users\arriane\source\repos\pdf creator resume\json file\jsonInfo.JSON";

        public _frmPDFgenerator()
        {
            InitializeComponent();
        }

        private void _btnJSON_Click(object sender, EventArgs e)
        {

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
            using (var reader = new StreamReader(filepath))
            {
                jsonFile = reader.ReadToEnd();
            }
            var Resume = JsonConvert.DeserializeObject<ResumeContent>(jsonFile);

            //name, address and contact number
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
            string SoftSkill_5 = Resume.SoftSkill_5;

            //Hard Skills
            string HardSkill_1 = Resume.HardSkill_1;
            string HardSkill_2 = Resume.HardSkill_2;
            string HardSkill_3 = Resume.HardSkill_3;
            string HardSkill_4 = Resume.HardSkill_4;
            string HardSkill_5 = Resume.HardSkill_5;
            

            //Work Experience
            string WorkExperience_1 = Resume.WorkExperience_1;
            string WorkExperience_2 = Resume.WorkExperience_2;
            string WorkExperience_3 = Resume.WorkExperience_3;
            string WorkExperience_4 = Resume.WorkExperience_4;
        }
    }
}
