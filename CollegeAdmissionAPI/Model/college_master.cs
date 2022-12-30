using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionAPI.Model
{
    public class college_master
    {
        public int College_Id { get; set; } = 0;
        public string College_Name { get; set; } = null;
    }
    public class branch_master
    {
        public int Branch_Id { get; set; } = 0;
        public int College_Id { get; set; } = 0;
        public string Branch_Name { get; set; } = null;
        public double Fees { get; set; } = 0;
    }

    public class Registration_Details
    {
        public int Branch_Id { get; set; } = 0;
        public int College_Id { get; set; } = 0;
        public int Registration_Id { get; set; }
        public string Applicant_Name { get; set; }
        public string Email_Id { get; set; }
        public string Mobile_No { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Image_path { get; set; }

    }
}
