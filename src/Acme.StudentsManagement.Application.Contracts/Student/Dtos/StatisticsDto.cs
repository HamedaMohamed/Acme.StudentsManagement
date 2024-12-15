﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.StudentsManagement.Student.Dtos
{
    public class StatisticsDto
    {
        public int TotalStudents { get; set; }
        public double AverageAge { get; set; }
        public Dictionary<string, int> GradeDistribution { get; set; }
    }
}
