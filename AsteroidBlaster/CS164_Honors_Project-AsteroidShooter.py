import pygame.draw
import random
pygame.init()
display = pygame.display.set_mode((640,640))
pygame.display.set_caption("AsteroidShooter Blaster")
display.fill((0,0,0))
font1 = pygame.font.Font("C:\Windows\Fonts\COOPBL.TTF",200)
font = pygame.font.Font("C:\Windows\Fonts\COOPBL.TTF",50)

pygame.display.update()

run = True         #true when the program is running for the loop - false when the user closes out the program
blasterpos = 320   #x position of the spaceship/blaster

blastposx = 320    #x position of the  actual shots from the blaster
blastposy = 610    #y position of the  actual shots from the blaster
blast = False      #whether there is a shot/blast on screen right now

scoring_possible = False #if there is a shot/blast on screen, then scoring is possible at the moment
score = 0 #Keeps track of the score
gameOver = True  #Determines whether the game is over or not

#Variables for the Asteroids
yposition = [0,0,0,0,0,0]  #yposition of the six asteroids in an array format
xposition = [random.randint(20,600), random.randint(20,600),  #sets the xposition of each asteroid to a random x-coord
             random.randint(20,600), random.randint(20,600), random.randint(20,600), random.randint(20,600)]
speed_mult = 0.0075  #variable that is the high end of the random asteroid speed
speed = [random.uniform(.005, speed_mult), random.uniform(.005, speed_mult), #Sets the asteroid speed to a random value
         random.uniform(.005, speed_mult), random.uniform(.005, speed_mult), random.uniform(.005, speed_mult), random.uniform(.005, speed_mult)]




while run:
    #The menu screen/the screen when you lose
    if(gameOver):
        display.fill((0, 0, 0))
        scoretext = font1.render(str(score), True, (200, 200, 255))
        display.blit(scoretext, (260, 60))

        prevscore = font.render("Previous Score:", True, (200, 200, 255))
        display.blit(prevscore, (140, 40))

        prevscore = font.render("Left Click to Play", True, (200, 200, 255))
        display.blit(prevscore, (25, 500))

        pygame.display.update()
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                run = False
            #If the game is started by the user by clicking your mouse
            if event.type == pygame.MOUSEBUTTONDOWN:
                gameOver = False
                score = 0
                #Resets all the variables for the next game
                for x in range(6):
                    speed_mult = 0.0075
                    speed[x] = random.uniform(.005, speed_mult)
                    yposition[x] = 0
                    xposition[x] = random.randint(40, 620)
                    blasterpos = 320


    #If the game is started by the user
    else:
        display.fill((0,0,0))


        #Sets the variables for the Asteroids. the Yposition of the Asteroid is set to the current yposition
        #plus the speed of the asteroid. It also draws in the updated asteroids. If the asteroid reaches the
        #level of the blaster/spaceship, the game is over.
        for x in range(6):
            yposition[x] = yposition[x] + speed[x]
            pygame.draw.circle(display, (255, 255, 255), (xposition[x], yposition[x]), 20, 20)
            if(yposition[x]>=585):
                gameOver = True



        #Moves the blaster/spaceship.
        #Left Arrow makes it go left
        #Right Arrow makes it go right
        keys = pygame.key.get_pressed()
        if (blasterpos < 600 and keys[pygame.K_RIGHT]):
            blasterpos = blasterpos + .1
        if (blasterpos > 0 and keys[pygame.K_LEFT]):
            blasterpos = blasterpos - .1

        #Draws the blaster/spaceship to the current position based off
        #the left/right arrows
        pygame.draw.rect(display, (255,0,0), (blasterpos, 620, 40,20))
        pygame.draw.rect(display, (255,0,0), (blasterpos+15, 610, 10, 15))



        #Checks for which keys are hit
        for event in pygame.event.get():
            #If you close the tab, run is set to false stopping the loop
            if event.type == pygame.QUIT:
                run = False
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_SPACE:
                    blast = True
                    scoring_possible = True

        #Keeps track of the blaster/spaceship position in order to determine the x-cord of the blast/shot
        #when it is eventually shot.
        if(not blast):
            blastposy = 610
            blastposx = blasterpos + 15
        #If a blast/shot is called upon, then it creates a shot that goes up the screen
        #until it disappears
        else:
            pygame.draw.rect(display, (0,255,0), (blastposx, blastposy, 10, 20))
            blastposy = blastposy - .75
            #If the blast/shots y position is off the screen, then the blast/shot is reset
            if(blastposy<0):
                blastposy = 610
                blast = False

        #Loops through each asteroid and checks if a blast/shot hits the asteroid
        #If it does hit, then it increases the range for the random Asteroid speed and increases
        #the score by 1. Then it sends that asteroid back to the top of the screen
        #to come down again.
        for x in range(6):
            if (xposition[x] - 20 < blastposx and xposition[x] + 20 > blastposx
                and yposition[x]-10 < blastposy and yposition[x] + 10 > blastposy and scoring_possible):
                score = score + 1
                xposition[x] = random.randint(20,620)
                yposition[x] = 0
                speed_mult = speed_mult + .0005
                speed[x] = random.uniform(0.075, speed_mult)
                scoring_possible = False


        #Outputs the text for the current score on the top right of the screen
        scoretext = font.render(str(score), True, (0,0,255))
        rect = scoretext.get_rect()
        rect.topright
        display.blit(scoretext,rect)




        pygame.display.update()

pygame.quit()



