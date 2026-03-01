namespace FileSystem;


public class FileSystemClass
{

#pragma warning disable 0219
    FileStream fs = null;
#pragma warning restore 0219

    public FileSystemClass()
    {
    }

    public BinaryReader ReadToBinaryFile(string path)
    {
        BinaryReader br = null;

        try
        {

            fs = new FileStream(path, FileMode.Open);
            using (fs)
            {
                br = new BinaryReader(fs);
                ;
            }

            return br;
        }
        catch (Exception e)
        {
            // Console.WriteLine(e.Message);
            if (fs != null)
            {
                Console.WriteLine("Corrupted file, closing");
                fs.Close();
            }
            else // null - file not found
            {
                //Console.WriteLine("Missing file");
                throw new IOException("Missing File");
            }

        }

        return br;
    }
}