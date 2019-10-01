using System;

public interface ISNchecker
{
    void Check(string login,string pass);
    bool AuthorizeCheck(string login, string pass);
    string GetData(string nameRow);
}
