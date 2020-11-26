void Main(string[] args)
        {
            //drive info
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"Drive name: {drive.Name}");
                    Console.WriteLine($"Format: {drive.DriveFormat}");
                    Console.WriteLine($"Type: {drive.DriveType}");
                    Console.WriteLine($"Root directory: {drive.RootDirectory}");
                    Console.WriteLine($"Volume label: {drive.VolumeLabel}");
                    Console.WriteLine($"Free space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Available space:{ drive.AvailableFreeSpace}");
					Console.WriteLine($"Total size: {drive.TotalSize}");
                    Console.WriteLine();
                }
            }
			
            //xuat file
            string rootPath = @"C:\Users\luan\Documents";
            string[] dirs = Directory.GetDirectories(rootPath);
            foreach(string dir in dirs)
            {
                Console.WriteLine(dir);
            }  
			
            //tao file
            /*
            string path = @"c:\temp123\excerciseCS.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Welcome");
                    sw.WriteLine("To");
                    sw.WriteLine("The live of my");
                }
            }
            */
			
            // Open file         
            string path = @"c:\temp123\excerciseCS.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            } 
        }
    }
}