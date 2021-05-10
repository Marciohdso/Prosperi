using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SqlAdapter
{
    public class SqlAdapterConfiguration
    {
        [Required]
        public string ConnectionString { get; set; }
    }
}
