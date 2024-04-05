String s = "pwwkew";

int LengthOfLongestSubstring(string s)
{
    if (s == "") {  return 0; }
    else if(s.Length == 1) { return 1; }
    else
    {
        string list ="";
       List<string> list2 = new List<string>();

        //int j = 0;
        //list += s[0];
        for (int i = 0; i < s.Length; i++)
        {
            list += s[i];
            for(int j = i+1; j < s.Length; j++)
            {
                if (!list.Contains(s[j]))
                {
                    list += s[j];
                }
                else
                {
                    break;
                }
                

            }
            list2.Add(list);
            list = "";
           
        }
        list2.Add(list);
        return list2.Max(s=>s.Length);
    }
}

Console.WriteLine(LengthOfLongestSubstring(s));