# ParticlePhoton-XamarinForms-LEDBasic
Xamarin.Forms Application that uses Visual Studio (on Mac or Windows) to build iOS and Android apps that work to control Particle Photon MicroControllers. 
###### Note: Instead of only using LEDs, you can hook up a motor to the D7 pin and effectively turn on and off a minifan with your phone

## 1. Purpose
This repository contains the code needed to perform basic On & Off (Post) functions to Tinker with Photon Particle controlled IoT devices

## 2. Motivation
I participated in a lot of hackathons and won a bunch, and attribute a lot of my winnings to the Particle Photon. So, I made this repository to help others reach their dreams and do some real winning.
So if you ever find my repo. helpful, please give me a shoutout, or like me at facebook.com/prototypemakers
I always welcome constructive criticism and let me know if you want to see more!!

## 3. How to Use this
Once you have the particle photon and you follow instructions to set it up https://www.particle.io
### 3.1 You need to buy
A particle photon, but I'm sure it will work for Particle Core, Particle Electron, RedBear Duo
Once you have set up the device and claimed it to your account, go to build.particle and login with the account. 

### 3.2 What code do I put on the Microcontroller
Put in the code from MicroControllerCode.cpp file in this directory, into the Particle Build Web IDE.

It was taken from "Blink an Led-Setup" on this page https://docs.particle.io/guide/getting-started/examples/photon/#blink-an-led and upload it to your device

### 3.3 How do I know that I set up the  correctly
Follow instructions in the docs website above, or you can go to this codepen and change the UserID and AccessToken https://codepen.io/saamerm/pen/GMqWej and try to change the LED status to on. If the light goes on, you're in business.

### 3.4 Ready to build that mobile app?
Once you make sure the device works in the codepen, Fork this repository, Clone it to your computer, and open the solution in Visual Studio.
In the ParticlePhotonLED.cs file, change the UserID and AccessToken to what you want, and Voila. It should work.

## 4. Doesnt work?
Email me at i@saamer.me

## 5. Bonus
Control the device with an Android watch! :) https://github.com/saamerm/Xamarin.Android-Wear-2.0-IpInfo-Rest-Api-Get
