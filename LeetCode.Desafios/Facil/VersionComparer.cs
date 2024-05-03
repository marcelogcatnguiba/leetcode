namespace LeetCode.Desafios.Facil
{
    public class VersionComparer
    {
        public int Comparer(string version1, string version2)
        {
            string[] vect1 = version1.Split('.');
            string[] vect2 = version2.Split('.');
            int len1 = vect1.Length;
            int len2 = vect2.Length;

            var len = len1 > len2 ? len2 : len1;

            int result = 0;
            for (int i = 0; i <= len - 1; i++)
            {
                if (int.Parse(vect1[i]) == int.Parse(vect2[i]))
                    continue;

                result = int.Parse(vect1[i]) > int.Parse(vect2[i]) ? 1 : -1;
                break;
            }

            if (result == 0 && len1 != len2)
            {
                if (len == len1)
                {
                    return vect2[(len)..].Any(x => int.Parse(x) > 0)
                        ? -1
                        : result;
                }
                else
                {
                    return vect1[(len)..].Any(x => int.Parse(x) > 0)
                        ? 1
                        : result;
                }
            }

            return result;
        }
    }
}