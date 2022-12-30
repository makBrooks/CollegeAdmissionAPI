using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionAPI.Repository
{
    public class CollegeAdmissionRepository : BaseRepository, ICollegeAdmissionRepository
    {
        public CollegeAdmissionRepository(IConfiguration configuration) : base(configuration)
        {

        }


    }
}
