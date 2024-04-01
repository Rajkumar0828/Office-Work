namespace Jenkinsdemo
{
    public class Testme
    {
        public string sayJenkins(int times)
        {
            string name = "";
            for  (int i = 0;i<times;i++)
            {
                name += "Jen" +
                    "kins";
            }
            return name;
        }
    }
}
