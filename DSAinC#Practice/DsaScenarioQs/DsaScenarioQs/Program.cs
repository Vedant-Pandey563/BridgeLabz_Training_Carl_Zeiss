using System.Security.Cryptography.X509Certificates;

namespace DsaScenarioQs
{
    public class SensorWindow
    {
        private class Bucket //bucket stores sum and cnt of incoming 
        {
            public double Sum;
            public int Count;
        }
        
        private readonly Bucket[] buckets = new Bucket[60]; // circle arr of buvket size 60
        private double totalSum = 0; //bucket sum last 60 secs
        private int totalCount = 0; //bucket cnt last 60 secs
        public SensorWindow()
        {
          for(int i =0; i<60; i++)
          {
            buckets[i] = new Bucket(); // get value at ith postion
          }
        }

        

        //process 1 incoming reading
        public void AddReading(long timestamp,double value) // 
        {
            int index = (int)(timestamp%60); // to get circular arr index

            //rempove old data at index before
            totalSum -= buckets[index].Sum; 
            totalCount -= buckets[index].Count;

            //reset index data to 0
            buckets[index].Sum = 0;
            buckets[index].Count = 0;

            //add data to index
            buckets[index].Sum += value;
            buckets[index].Count += 1;

            //add to global value
            totalSum += value;
            totalCount += 1;
        }

        public double GetAverage()//getting current average
        {
            if (totalCount == 0)
            {
                return 0;   
            }

            return totalSum / totalCount;
        }

        public bool IsSpike(double value)//checking for spike of curr value
        {
            double avg = GetAverage();
            return value > (3 * avg);
        }
    }   
    
    public class SensorSystem
    {
        private Dictionary<int, SensorWindow> sensors = new Dictionary<int, SensorWindow>();

        public void ProcessReading(int sensorId,long timestamp,double value)
        {
            if(!sensors.ContainsKey(sensorId))
            {
                sensors[sensorId] = new SensorWindow();
            }

            SensorWindow window = sensors[sensorId];

            window.AddReading(timestamp, value);

            if(window.IsSpike(value))
            {
                Console.WriteLine($"Spike Detected at {sensorId}");
            }

        }

        public double GetSensorAverage(int sensorId)
        {
            if (!sensors.ContainsKey(sensorId))
                {
                return 0;
                }

            return sensors[sensorId].GetAverage();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Sensor Readings");

            SensorSystem system = new SensorSystem();

            system.ProcessReading(1, 100, 50);
            system.ProcessReading(1, 101, 55);
            system.ProcessReading(1, 102, 60);

            Console.WriteLine("Average = " + system.GetSensorAverage(1));
            
            system.ProcessReading(1, 103, 500); // spike triggers alert
        }
    }
}
