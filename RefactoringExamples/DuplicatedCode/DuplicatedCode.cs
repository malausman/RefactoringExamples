
using System;

namespace CleanCode.DuplicatedCode
{
    class DuplicatedCode
    {
        public void AddStudent(string name, string admissionDateTime)
        {
            int time;
            int hours = 0;
            int minutes = 0;
            if (!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if (int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }

            }
            else
                throw new ArgumentNullException("admissionDateTime");

            // Some logic 

           
        }

        public void UpdateStudentAdmission(int admissionId, string name, string admissionDateTime)
        {

            int time;
            int hours = 0;
            int minutes = 0;
            if (!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if (int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }
            }
            else
                throw new ArgumentNullException("admissionDateTime");

            // Some  logic 

           
        }
    }
}
