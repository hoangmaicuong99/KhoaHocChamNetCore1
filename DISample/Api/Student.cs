using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DISample.Api
{
    public class Student
    {
        public IConfiguration _configuration { get; }
        public Student(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Student()
        {
        }

        public string GetString()
        {
            return _configuration.GetSection(key: "Message").Value;
        }
    }
}
