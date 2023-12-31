﻿using System.ComponentModel.DataAnnotations.Schema;

namespace slack_api_1.Models
{
    public class slackModel
    {
       
        public int Id { get; set; }

        public string? slack_name { get; set; }
        public string? current_day { get; set; }

        public string? utc_time { get; set; }

        public string? track { get; set; }

        public string? github_file_url { get; set;}

        public string? github_repo_url { get; set;}

        public int status_code { get; set;}
    }

}
