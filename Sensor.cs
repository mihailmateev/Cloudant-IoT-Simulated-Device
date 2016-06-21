using System;

namespace CloudantCRUD
{
    #region Sensor
    /// <summary>
    /// Sensor class 
    /// this class is used to manage data from sensors
    /// </summary>
    public class Sensor
    {
        public string _id;
        public string recordtitle;
        public string record;
        public string origtime;
        public int displacement;
        public int temp;
        public int hmdt;
        public long modified;
        public string tags;

        static Random R = new Random();
        static string[] sensorNames = new[] { "sensorA", "sensorB", "sensorC", "sensorD", "sensorE" };
        //DateTime.Now.Date.Ticks - DateTime.Parse("01/01/1970 00:00:00").Date.Ticks
        public static Sensor Generate()
        {
            var sensorname = sensorNames[R.Next(sensorNames.Length)];
            var id = DateTime.Now.ToJavaScriptMilliseconds().ToString();
            return new Sensor { origtime = DateTime.UtcNow.ToString(), displacement = R.Next(30, 70), temp = R.Next(70, 150), hmdt = R.Next(30, 70),  modified = DateTime.Now.ToJavaScriptMilliseconds(), recordtitle = sensorname,  record = sensorname + " record", _id = id, tags = "Generated" };
        }

        public static Sensor Update(Sensor sensor, string revision)
        {
            return new Sensor { origtime = sensor.origtime, displacement = sensor.displacement, temp = sensor.temp, hmdt = sensor.hmdt, modified = DateTime.UtcNow.Ticks, record = sensor.record, recordtitle = sensor.recordtitle };
        }
    }

    #endregion Sensor
}
