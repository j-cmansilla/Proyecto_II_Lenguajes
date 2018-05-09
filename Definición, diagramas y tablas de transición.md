# Definición formal de las máquinas

## 1. Palabras palíndromas
**1.  Definición formal:**
$M =\lbrack\lbrace q0,q1,q2,q3,q4,q5,q6,q7,q8\rbrace , \lbrace a,b,c \rbrace , \lbrace a,b,c,ß \rbrace, \lbrace q0 \rbrace, \lbrace \beta \rbrace,\lbrace q8 \rbrace, \delta \rbrack$
**2. Diagrama de transiciones:**

![enter image description here](https://lh3.googleusercontent.com/HGtfPqiv6x9WSv-h4VTyymVpHjl1sbiv_HnPbHYM0gLdVo08OULsbiNIqhygWGTdUhVZo99kwu7d)

**3. Tabla de transiciones:** 

Estado | a | b | c |ß
-- | -- |-- | --|--
$\to$ q0  | q1,ß/R | q2,ß/R | q3,ß/R|q8,ß/L
q1  | q1,a/R | q2,b/R | q3,c/R|q4,ß/L
q2  | q2,a/R | q2,b/R | q2,c/R|q5,ß/L
q3  | q3,a/R | q3,b/R | q3,c/R|q6,ß/L
q4  | q7,ß/R | -------- | --------|q8,ß/L
q5  | -------- | q7,ß/R |--------|q8,ß/L
q6  | -------- | -------- | q7,ß/R|q8,ß/L
q7  | q1,a/L | q2,b/L | q3,c/L|q0,ß/R
***q8**  | -------- | -------- | --------|--------

## 2. Copiar patrones
**1.  Definición formal:**
$M =\lbrack\lbrace q0,q1,q2,q3,q4,q5,q6,q7,q8\rbrace , \lbrace a,b,c,A,B,C \rbrace , \lbrace a,b,c,A,B,C,ß \rbrace, \lbrace q0 \rbrace, \lbrace \beta \rbrace,\lbrace q8 \rbrace, \delta \rbrack$
2. Diagrama de transiciones:

![enter image description here](https://lh3.googleusercontent.com/nwakgwcMHicC6cXcmQNFmvmrlQCFbVrjo_XjH_epdYwokbEW-5qKA7Zy7kc2EGC_QZympahwnn4s)

**3. Tabla de transiciones:** 

![enter image description here](https://lh3.googleusercontent.com/u-QPtSF8xbudFXzD0K-4wrPp9VvSPjLbmzpHbC1mAIHYf3TmLAocgQ3zovm69KHSi-_snXrAeZXY)

## 3. Multiplicación unaria
**1.  Definición formal:**
$M =\lbrack\lbrace q0,q1,q2,q3,q4,q5,q6\rbrace , \lbrace |,*,= \rbrace , \lbrace |,*,=,X,Y,ß \rbrace, \lbrace q0 \rbrace, \lbrace \beta \rbrace,\lbrace q6 \rbrace, \delta \rbrack$
**2. Diagrama de transiciones:**


![enter image description here](https://lh3.googleusercontent.com/uFMGlh1ShGOCDh6BFj4YRxxmkC21UeaxaaFEVAG1YHOLcrmx1quKvxvGLqsTZYaL42BZ7TD3qidL)

**3. Tabla de transiciones:** 

![enter image description here](https://lh3.googleusercontent.com/Mros9IT0KW_BoaTmjXeWbQ2p6pdjd_0MbvhdxApPz-iYhhMGoga4SYaUE6GK0Crk2BfRkcOmKXcX)

## 4. Suma unaria
**1.  Definición formal:**
$M =\lbrack\lbrace q0,q1,q2,q3\rbrace , \lbrace |,+ \rbrace , \lbrace |,+,ß \rbrace, \lbrace q3 \rbrace, \lbrace \beta \rbrace,\lbrace q8 \rbrace, \delta \rbrack$
**2. Diagrama de transiciones:**

![enter image description here](https://lh3.googleusercontent.com/R1bQOW6e0iIjLID4GkPP_QEAXPkSk-aRY2xhc-f9WM5Wc02OmFaiuYOP2MoVKipcA9pzw0g495Bv)

**3. Tabla de transiciones:** 

![enter image description here](https://lh3.googleusercontent.com/0i86JWsdpQLCDdf0dMxARwAwe55kE3yU6SNc6rldvGaGDS-pBHWQ62J6pvqcOrGyOT2CNCCvM6Ki)

## 5. Resta unaria
**1.  Definición formal:**
$M =\lbrack\lbrace q0,q1,q2,q3,q4,q5,q6\rbrace , \lbrace |,- \rbrace , \lbrace |,+,ß \rbrace, \lbrace q3 \rbrace, \lbrace \beta \rbrace,\lbrace q8 \rbrace, \delta \rbrack$
**2. Diagrama de transiciones:**

![enter image description here](https://lh3.googleusercontent.com/HJrVUSWlImkjtsUAXXl4hpwnt2LHjAYQtemPOQh20vrouHIaKoWUybdrHWyEpERvLEQeDSW5X1y6)

**3. Tabla de transiciones:**

![enter image description here](https://lh3.googleusercontent.com/9DnKA6fo64JiLdkdoHoB3NIhcEpyuShZBMD49JzpQ_fwTfDlLNroBXRgP3cYuR8yiKmdA9PfJbit)
