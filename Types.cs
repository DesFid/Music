using System;
using System.Collections.Generic;

class Types
{
    public IList<string> MusicTypes(){
    IList<string> types = new List<string>();
        types.Add("Punk");
        types.Add("Pop");
        types.Add("Hip Hop");
        types.Add("Jazz");
        types.Add("Opera");
    return types;
}
}