using System;
using System.Collections.Generic;

class Repertories
{
    public IList<string> MusicRepertories(){
        IList<string> repertories = new List<string>(new string[] {"operatic", "coral", "theatrical", "musical", "archaeological", "numerical"});
        return repertories;
    }
}