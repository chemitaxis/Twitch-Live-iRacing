using Newtonsoft.Json;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace Twitch_Live_iRacing.Utils
{
    public class SeriesConversor : ISeriesConversor
    {
        private List<DataSeries>? dataSeries;

        public SeriesConversor() {

            string startupPath = Application.StartupPath;
            string jsonFilePath = Path.Combine(startupPath, "Utils\\SeriesList.json");
            string json = File.ReadAllText(jsonFilePath);

            dataSeries = JsonConvert.DeserializeObject<List<DataSeries>>(json);



        }
        public string ConvertFromIdToName(string id)
        {
            var foundOption = this.dataSeries.FirstOrDefault(o => o.Value == id);

            return foundOption.Text;


        }

    }
}
