using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.Adapter.Adapter.Adapter;

internal class JsonToString: IJsonToString
{
    string filename;
    public JsonToString(string filename)
    {
        this.filename = filename;
    }
    public string ConvertToString()
    {
        return File.ReadAllText(filename);
    }
}
