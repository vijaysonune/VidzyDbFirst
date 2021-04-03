using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyDbFirst
{
    enum ClassificationVideo
    {
        Gold=1,
        Silver=2,
        Platinium=3,
        Premium=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context =new VidzyDbContext();
            Video video = new Video();
            video.Name = "";
            
            context.AddVideo("Race 2", DateTime.Now, "Action", 3);
        }
    }
}
