﻿// рекурсивная функция обработки строки
static string ConvertStr(string s, int pos, char c, int k, string s2)
{
  if (pos < s.Length) // пока не последний символ S[pos] - осуществляются рекурсивные вызовы
  {
    if (pos == 0) // первый символ строки
      // перейти к обработке следующего символа
      return ConvertStr(s, pos + 1, s[pos], 1, s2);
    else // не первый символ строки
    {
      if (s[pos] == c) // если следующий и предыдущий символы совпадают, то движемся дальше
        return ConvertStr(s, pos + 1, s[pos], k + 1, s2);
      else // если символы отличаются, то зафиксировать в строке s2 временный результат
      {
        // если k==1, то просто добавить к s2 символ c,
        // иначе, перед символом c поставить число k
        if (k == 1)
          s2 = s2 + c.ToString();
        else
          s2 = s2 + k.ToString() + c.ToString(); // s2 = s2 + "AAA' = s2 + "3A"
        // перейти на следующий уровень рекурсии, продолжить обработку строки
        return ConvertStr(s, pos + 1, s[pos], 1, s2);
      }
    }
  }
  else // пройдена вся строка
  {
    // завершить обработку строки
    if (k == 1)
      s2 = s2 + c.ToString();
    else
      s2 = s2 + k.ToString() + c.ToString();
    return s2; // окончание рекурсивного процесса
  }
}