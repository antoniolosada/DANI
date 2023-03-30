################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src\Wire.cpp 

LINK_OBJ += \
.\libraries\Wire\src\Wire.cpp.o 

CPP_DEPS += \
.\libraries\Wire\src\Wire.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
libraries\Wire\src\Wire.cpp.o: C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src\Wire.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Adafruit_VL53L0X\1.2.2\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\HID\src" -I"C:\Users\antonio\Documents\Arduino\libraries\TFT\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Ethernet\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Mouse\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Stepper\src" -I"C:\Users\antonio\Documents\Arduino\libraries\LiquidCrystal\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata\utility" -I"C:\Users\antonio\Documents\Arduino\libraries\Keyboard\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SD\src" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '


