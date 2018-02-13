##Specs

* _Take single word to compare to list_
    input: bread
    output: bread

* _Take multiple word input_
    input: word, garbage, soylent, water
    output: "word, garbage, soylent, water"

* _Break multiple word input into list_
    input: word, garbage, soylent, water
    output: List = "word", "garbage", "soylent", "water"    

* _Check letters in entered words_
    input: bread
    output: b r e a d

* _Compare letters of all words against each other_
    input: "b r e a d", "b e a r d"
    output: does b = b, does b = e, ...

* _Tell user which are anagrams_
    input: bread
    output: "beard" is an anagram of "bread"
