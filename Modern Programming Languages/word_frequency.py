from collections import Counter

text = input("Enter the text: ")

words = text.lower().split()
counter = Counter(words)

word, count = counter.most_common(1)[0]

print("Most used word:", word)
print("Usage count:", count)
