import math

PI = math.pi

def area(r):
    area = PI * r ** 2
    return area

def main():
    historyOfPrompt = []
    historyOfOutput = []

    def getInput(prompt):
        x = input(prompt)
        historyOfOutput.append(prompt)
        return x

    def showOutput(val):
        historyOfOutput.append(val)
        print(val)

    rString = getInput("Please enter the radius of a circle :")
    r = float(rString)
    val = area(r)
    showOutput(f"The area of the circle is {str(val)}")

if __name__ == "__main__":
    main()