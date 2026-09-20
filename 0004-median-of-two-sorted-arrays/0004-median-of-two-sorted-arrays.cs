public class Solution {
  public double FindMedianSortedArrays(int[] a, int[] b)
  {
    int n1 = a.Length, n2 = b.Length;
    if (n1 > n2) return FindMedianSortedArrays(b, a);

    int lo = 0, hi = n1;
    while (lo <= hi)
    {
      int cut1 = (lo + hi) / 2;
      int cut2 = (n1 + n2 + 1) / 2 - cut1;
      int l1 = (cut1 == 0 ? Int32.MinValue : a[cut1 - 1]);
      int l2 = (cut2 == 0 ? Int32.MinValue : b[cut2 - 1]);
      int r1 = (cut1 == n1 ? Int32.MaxValue : a[cut1]);
      int r2 = (cut2 == n2 ? Int32.MaxValue : b[cut2]);
      if (l1 <= r2 && l2 <= r1)
      {
        return (n1 + n2) % 2 == 1 ? Convert.ToDouble(Math.Max(l1, l2)) : Convert.ToDouble(Math.Max(l1, l2) + Math.Min(r1, r2)) / Convert.ToDouble(2);
      }
      else if (l1 > r2) hi = cut1 - 1;
      else lo = cut1 + 1;
    }
    return Convert.ToDouble(0);
  }
}