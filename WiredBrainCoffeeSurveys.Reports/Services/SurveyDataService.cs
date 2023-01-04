using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffeeSurveys.Reports.Services
{
    class SurveyDataService
    {
        public static SurveyResult GetSurveyDataByFileName(string fileName)
        {
            return JsonConvert.DeserializeObject<SurveyResult>
                    (File.ReadAllText($"data/{fileName}.json"));
        }
    }
}
