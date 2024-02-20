using System.Collections.Generic;

public class DataContainer
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private List<string> dataList;

    public List<string> DataList
    {
        get { return dataList; }
        set { dataList = value; }
    }
}