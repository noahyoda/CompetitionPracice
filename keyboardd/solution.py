line1 = ""
line1 = input()
line2 = ""
line2 = input()
stickies = ""
pos = 0

while len(line2) >= len(line1) and pos < len(line1):
    if line2[pos] != line1[pos]:
        if not line2[pos] in stickies:
            stickies += line2[pos]
        line2 = line2[:pos] + line2[pos + 1 :]
    if line2[pos] == line1[pos]:
        pos += 1
if pos < len(line2):
    stickies += line2[pos]

print(stickies)
