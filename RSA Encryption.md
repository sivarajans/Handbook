## RSA Encryption

### Steps
1. Choose 2 Prime Numbers called `p` and `q`
2. Multiply them and get Highest Common Factor `HCF` called `N`
3. Get `Φ` value of `N` called Φ(N) here Φ means - No of numbers which are not common factors
4. Find Encryption Key called `e`
5. Find Decryption Key called `d`


### Formula
1. Initialize 2 Prime `p` and `q`
2. Find `N = pq`
3. Find `Φ(N) = (p-1)(q-1)`
4. Encryption key `e` is `1 < e < Φ(N)` and `Co prime with Φ(N) and N`
5. Equation to find `d` is `ed mod Φ(N) = 1`

### Sample
Assume *`p = 13`* and *`q = 23`*

Let's find `N` and `Φ(N)`

*`N = pq = (13 * 23) = 299`*
*`Φ(N) = (p-1)(q-1) = (12 * 22) = 264`*

Lets find Encryption Key, As per rule, encryption key should be between `1` and `Φ(N)` not inclusive. Also should be `co prime with N and Φ(N)`.
So here I consider *`e = 19`* which satisfy these rules.

*`e = 19`*

Now as per equation `ed mod Φ(N) = 1`, I consider *`d = 139`* which satisfies and resulted as 1.
so *`(19 * 139) mod 264 = 1`*

Finally we got below values  
`p = 13`   
`q = 23`  
`N = 299`  
`Φ(N) = 264`  
`e = 19`  
`d = 139`  


