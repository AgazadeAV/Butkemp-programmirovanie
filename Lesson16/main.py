import cv2

img = cv2.imread('C:/Users/ASUS/Desktop/GeekBrains/Butkemp-programmirovanie/Lesson16/test.jpg')

img = cv2.resize(img, (500, 500))

cv2.imshow('Result', img)

cv2.waitKey(1000)