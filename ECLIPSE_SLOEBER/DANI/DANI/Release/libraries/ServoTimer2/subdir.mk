################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2\ServoTimer2.cpp 

LINK_OBJ += \
.\libraries\ServoTimer2\ServoTimer2.cpp.o 

CPP_DEPS += \
.\libraries\ServoTimer2\ServoTimer2.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
libraries\ServoTimer2\ServoTimer2.cpp.o: C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2\ServoTimer2.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Adafruit_VL53L0X\1.2.2\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\VL53L0X\1.3.1" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\HID\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\TFT\1.0.6\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Ethernet\2.0.0\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Mouse\1.0.1\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Stepper\1.1.3\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\LiquidCrystal\1.0.7\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Firmata\2.5.8" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Servo\1.1.8\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Firmata\2.5.8\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Keyboard\1.0.3\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\SD\1.2.4\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '


