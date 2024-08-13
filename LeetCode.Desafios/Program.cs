string s = "abcabcbb";

int i = 0;
int r = 0;
char c = '\0';

while (i < s.Length)
{
    if (c == '\0')
    {
        c = s[i];
        r++;
    }

    r = s[i] != c
        ? r++
        : 0;

    c = s[i];

    i++;
}

System.Console.WriteLine(r);