################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
C:\Users\antonio\Documents\Arduino\libraries\TFT\src\utility\Adafruit_GFX.cpp \
C:\Users\antonio\Documents\Arduino\libraries\TFT\src\utility\Adafruit_ST7735.cpp 

C_SRCS += \
C:\Users\antonio\Documents\Arduino\libraries\TFT\src\utility\glcdfont.c 

C_DEPS += \
.\libraries\TFT\src\utility\glcdfont.c.d 

LINK_OBJ += \
.\libraries\TFT\src\utility\Adafruit_GFX.cpp.o \
.\libraries\TFT\src\utility\Adafruit_ST7735.cpp.o \
.\libraries\TFT\src\utility\glcdfont.c.o 

CPP_DEPS += \
.\libraries\TFT\src\utility\Adafruit_GFX.cpp.d \
.\libraries\TFT\src\utility\Adafruit_ST7735.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
libraries\TFT\src\utility\Adafruit_GFX.cpp.o: C:\Users\antonio\Documents\Arduino\libraries\TFT\src\utility\Adafruit_GFX.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Adafruit_VL53L0X\1.2.2\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\HID\src" -I"C:\Users\antonio\Documents\Arduino\libraries\TFT\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Ethernet\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Mouse\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Stepper\src" -I"C:\Users\antonio\Documents\Arduino\libraries\LiquidCrystal\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata\utility" -I"C:\Users\antonio\Documents\Arduino\libraries\Keyboard\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SD\src" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

libraries\TFT\src\utility\Adafruit_ST7735.cpp.o: C:\Users\antonio\Documents\Arduino\libraries\TFT\src\utility\Adafruit_ST7735.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Adafruit_VL53L0X\1.2.2\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\HID\src" -I"C:\Users\antonio\Documents\Arduino\libraries\TFT\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Ethernet\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Mouse\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Stepper\src" -I"C:\Users\antonio\Documents\Arduino\libraries\LiquidCrystal\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata\utility" -I"C:\Users\antonio\Documents\Arduino\libraries\Keyboard\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SD\src" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

libraries\TFT\src\utility\glcdfont.c.o: C:\Users\antonio\Documents\Arduino\libraries\TFT\src\utility\glcdfont.c
	@echo 'Building file: $<'
	@echo 'Starting C compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-gcc" -c -g -Os -w -std=gnu11 -ffunction-sections -fdata-sections -MMD -flto -fno-fat-lto-objects -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Adafruit_VL53L0X\1.2.2\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\HID\src" -I"C:\Users\antonio\Documents\Arduino\libraries\TFT\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Ethernet\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Mouse\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Stepper\src" -I"C:\Users\antonio\Documents\Arduino\libraries\LiquidCrystal\src" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata" -I"C:\Users\antonio\Documents\Arduino\libraries\Firmata\utility" -I"C:\Users\antonio\Documents\Arduino\libraries\Keyboard\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SD\src" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '


