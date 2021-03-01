# FourSquareCypher

Four-Square Cipher
Introduction 
The Four-square cipher encrypts pairs of letters (like playfair), which makes it significantly stronger than substitution ciphers etc. since frequency analysis becomes much more difficult.

Felix Delastelle (1840 - 1902) invented the four-square cipher, first published in a book in 1902. Delastelle was most famous for his invention of several systems of polygraphic substitution ciphers including bifid, trifid, and the four-square cipher.

For a guide on how to break the foursquare cipher using Simulated Annealing, see Cryptanalysis of the Foursquare Cipher.

The Algorithm 
The four-square cipher uses four 5 by 5 matrices arranged in a square. Each of the 5 by 5 matrices contains 25 letters, usually the letter 'j' is merged with 'i' (wikipedia says 'q' is omitted, it is not very important since both q and j are rather rare letters). In general, the upper-left and lower-right matrices are the "plaintext squares" and each contain a standard alphabet. The upper-right and lower-left squares are the "ciphertext squares" and contain a mixed alphabetic sequence.

The ciphertext squares can be generated using a keyword (dropping duplicate letters), then fill the remaining spaces with the remaining letters of the alphabet in order. Alternatively the ciphertext squares can be generated completely randomly. The four-square algorithm allows for two separate keys, one for each of the two ciphertext matrices.

Steps 
Break up the plaintext into bigrams i.e. ATTACK AT DAWN --> AT TA CK AT DA WN
An 'X' (or some other character) may have to be appended to ensure the plaintext is an even length.

Using the four 'squares', two plain alphabet squares and two cipher alphabet squares, locate the bigram to encrypt in the plain alphabet squares. The example below enciphers the bigram 'AT'. The first letter is located from the top left square, the second letter is located in the bottom right square.

 
a b c d e   Z G P T F
f g h i k   O I H M U
l m n o p   W D R C N
q r s t u   Y K E Q A
v w x y z   X V S B L
 
M F N B D   a b c d e
C R H S A   f g h i k
X Y O G V   l m n o p
I T U E W   q r s t u
L Q Z K P   v w x y z
Locate the characters in the ciphertext at the corners of the rectangle that the letters 'AT' make:

 
a b c d e   Z G P T F
f g h i k   O I H M U
l m n o p   W D R C N
q r s t u   Y K E Q A
v w x y z   X V S B L
 
M F N B D   a b c d e
C R H S A   f g h i k
X Y O G V   l m n o p
I T U E W   q r s t u
L Q Z K P   v w x y z
Using the above keys, the bigram 'AT' is encrypted to 'TI'.

The text 'attack at dawn', with the keys 'zgptfoihmuwdrcnykeqaxvsbl' and 'mfnbdcrhsaxyogvituewlqzkp', becomes:

ATTACKATDAWN
TIYBFHTIZBSY
