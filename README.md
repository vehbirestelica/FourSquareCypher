# Four-SquareCypher

The four-square cipher is a manual symmetric encryption technique.[1] It was invented by the French cryptographer Felix Delastelle.

The technique encrypts pairs of letters (digraphs), and thus falls into a category of ciphers known as polygraphic substitution ciphers. This adds significant strength to the encryption when compared with monographic substitution ciphers which operate on single characters. The use of digraphs makes the four-square technique less susceptible to frequency analysis attacks, as the analysis must be done on 676 possible digraphs rather than just 26 for monographic substitution. The frequency analysis of digraphs is possible, but considerably more difficult - and it generally requires a much larger ciphertext in order to be useful.

Using four-square
The four-square cipher uses four 5 by 5 (5x5) matrices arranged in a square. Each of the 5 by 5 matrices contains the letters of the alphabet (usually omitting "Q" or putting both "I" and "J" in the same location to reduce the alphabet to fit). In general, the upper-left and lower-right matrices are the "plaintext squares" and each contain a standard alphabet. The upper-right and lower-left squares are the "ciphertext squares" and contain a mixed alphabetic sequence.

To generate the ciphertext squares, one would first fill in the spaces in the matrix with the letters of a keyword or phrase (dropping any duplicate letters), then fill the remaining spaces with the rest of the letters of the alphabet in order (again omitting "Q" to reduce the alphabet to fit). The key can be written in the top rows of the table, from left to right, or in some other pattern, such as a spiral beginning in the upper-left-hand corner and ending in the center. The keyword together with the conventions for filling in the 5 by 5 table constitute the cipher key. The four-square algorithm allows for two separate keys, one for each of the two ciphertext matrices.

As an example, here are the four-square matrices for the keywords "example" and "keyword." The plaintext matrices are in lowercase and the ciphertext matrices are in caps to make this example visually more simple:

1. a b c d e   E X A M P
1. f g h i j   L B C D F
1. k l m n o   G H I J K
1. p r s t u   N O R S T
1. v w x y z   U V W Y Z
 
1. K E Y W O   a b c d e
1. R D A B C   f g h i j
1. F G H I J   k l m n o
1. L M N P S   p r s t u
1. T U V X Z   v w x y z

Algorithm
To encrypt a message, one would follow these steps:

Split the payload message into digraphs. (HELLO WORLD becomes HE LL OW OR LD)
Find the first letter in the digraph in the upper-left plaintext matrix.
a b c d e   E X A M P
f g h i j   L B C D F
k l m n o   G H I J K
p r s t u   N O R S T
v w x y z   U V W Y Z
 
K E Y W O   a b c d e
R D A B C   f g h i j
F G H I J   k l m n o
L M N P S   p r s t u
T U V X Z   v w x y z
Find the second letter in the digraph in the lower-right plaintext matrix.
a b c d e   E X A M P
f g h i j   L B C D F
k l m n o   G H I J K
p r s t u   N O R S T
v w x y z   U V W Y Z
 
K E Y W O   a b c d e
R D A B C   f g h i j
F G H I J   k l m n o
L M N P S   p r s t u
T U V X Z   v w x y z
The first letter of the encrypted digraph is in the same row as the first plaintext letter and the same column as the second plaintext letter. It is therefore in the upper-right ciphertext matrix.
a b c d e   E X A M P
f g h i j   L B C D F
k l m n o   G H I J K
p r s t u   N O R S T
v w x y z   U V W Y Z
 
K E Y W O   a b c d e
R D A B C   f g h i j
F G H I J   k l m n o
L M N P S   p r s t u
T U V X Z   v w x y z
The second letter of the encrypted digraph is in the same row as the second plaintext letter and the same column as the first plaintext letter. It is therefore in the lower-left ciphertext matrix.
a b c d e   E X A M P
f g h i j   L B C D F
k l m n o   G H I J K
p r s t u   N O R S T
v w x y z   U V W Y Z
 
K E Y W O   a b c d e
R D A B C   f g h i j
F G H I J   k l m n o
L M N P S   p r s t u
T U V X Z   v w x y z
Using the four-square example given above, we can encrypt the following plaintext:

Plaintext:  he lp me ob iw an ke no bi
Ciphertext: FY GM KY HO BX MF KK KI MD
