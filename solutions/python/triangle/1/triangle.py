def equilateral(sides):
    for i in range(len(sides)):
        if sides[i] <= 0:
            return False

    if sides[0] + sides[1] < sides[2]:
        return False
    if sides[0] + sides[2] < sides[1]:
        return False
    if sides[2] + sides[1] < sides[0]:
        return False
            
    if sides[0] == sides[1] == sides[2]:
        return True
    return False


def isosceles(sides):
    for i in range(len(sides)):
        if sides[i] <= 0:
            return False

    if sides[0] + sides[1] < sides[2]:
        return False
    if sides[0] + sides[2] < sides[1]:
        return False
    if sides[2] + sides[1] < sides[0]:
        return False

    if sides[0] == sides[1] or sides[0] == sides[2] or sides[1] == sides[2]:
        return True
    return False
 

def scalene(sides):
    for i in range(len(sides)):
        if sides[i] <= 0:
            return False

    if sides[0] + sides[1] < sides[2]:
        return False
    if sides[0] + sides[2] < sides[1]:
        return False
    if sides[2] + sides[1] < sides[0]:
        return False

    if sides[2] != sides[0] != sides[1] != sides[2]:
        return True
    return False
