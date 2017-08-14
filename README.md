# [Consecutive strings](https://www.codewars.com/kata/56a5d994ac971f1ac500003e)

---

You are given an array `strarr` of strings and an integer `k`. Your task is to return the first longest string consisting of k consecutive strings taken in the array.

#Example: longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"

n being the length of the string array, if `n = 0` or `k > n` or `k <= 0` return "".

---

### 中文大意

從 array 中，取得連續 K 個字串結合起來的字串長度為最大值，如果有相同長度的，以最前面的為主
