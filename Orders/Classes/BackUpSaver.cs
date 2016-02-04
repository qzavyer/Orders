using System;
using System.IO;
using Orders.Classes.Exceptions;

namespace Orders.Classes
{
    public class BackUpSaver
    {
        private readonly string _path;

        public BackUpSaver(string path)
        {
            _path = path;
        }

        public void Save(string fileName)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + fileName + ".db";
            if (File.Exists(path))
            {
                var file = _path + "\\" + fileName + ".db";
                var i = 1;
                while (File.Exists(file))
                {
                    file = _path + "\\" + fileName + "[" + i + "]" + ".db";
                    i++;
                }
                File.Copy(path, file);
            }
            else
            {
                throw new WorkException("Файл базы данных не найден");
            }
        }
    }
}