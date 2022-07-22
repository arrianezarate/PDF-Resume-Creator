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
    public partial class _frmJSON : Form
    {
        private readonly string json_filepath = @"C:\Users\arriane\source\repos\pdf creator resume\json file\jsonInfo.JSON";

        public _frmJSON()
        {
            InitializeComponent();
        }

        private void _btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                var resume = GetResume();

                var jsonToWrite = JsonConvert.SerializeObject(resume, Formatting.Indented);

                using (var write = new StreamWriter(json_filepath))
                {
                    write.Write(jsonToWrite);
                }
            }
            catch (Exception)
            {
                // ignored
            }
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
            public string HardSkill_1 { get; set; }
            public string HardSkill_2 { get; set; }
            public string HardSkill_3 { get; set; }
            public string HardSkill_4 { get; set; }
            public string WorkExperience_1 { get; set; }
            public string WorkExperience_2 { get; set; }
            public string WorkExperience_3 { get; set; }
            public string WorkExperience_4 { get; set; }
            public string ContactNumber { get; set; }
            public string Email { get; set; }
        }

        private void _btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFile;
                using (var read = new StreamReader(json_filepath))
                {
                    jsonFile = read.ReadToEnd();
                }

                _tboxJSON.Text = jsonFile;

                var resumeFromJson = JsonConvert.DeserializeObject<ResumeContent>(jsonFile);
            }

            catch (Exception)
            {
                // ignored
            }
        }

        private ResumeContent GetResume()
        {
            var resume = new ResumeContent
            {

                Name = "Arriane Nicole Zarate",
                Address = "Cainta 1900",
                ContactNumber = "09776886853",
                Email = "arrianenic.z@gmail.com",
                Facebook = "https://www.facebook.com/arrianenicole.zarate",
                Github = "https://github.com/arrianezarate",
                Message = "I have seen this job posting on https://thevahub/real-estate-virtual-assistant/ for an internship Real Estate Virtual Assistant. I want to become part of your company.",
                SoftSkill_1 = "Critical Thinking Skills",
                SoftSkill_2 = "Great attention to Data",
                SoftSkill_3 = "Multi-tasking Skills",
                SoftSkill_4 = "Adaptability",
                HardSkill_1 = "Computer Literacy",
                HardSkill_2 = "Microsoft Tools (Word, Excel, etc.)",
                HardSkill_3 = "Web designing",
                HardSkill_4 = "Programming and HTML Languages (C#)",
                WorkExperience_1 = "Drive customer satisfaction through voice communications",
                WorkExperience_2 = "Navigate through miltiple systems with a computer specifically technical skill",
                WorkExperience_3 = "Remained courteous and calm.",
                WorkExperience_4 = "Listen attentively to caller needs.",

            };

            return resume;
        }
    }
}
