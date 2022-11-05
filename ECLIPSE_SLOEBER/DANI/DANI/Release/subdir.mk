################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
..\FiltroKalman.cpp \
..\LIDAR.cpp \
..\SAPPO.cpp \
..\UKF.cpp \
..\list.cpp \
..\node_cpp.cpp \
..\sloeber.ino.cpp 

LINK_OBJ += \
.\FiltroKalman.cpp.o \
.\LIDAR.cpp.o \
.\SAPPO.cpp.o \
.\UKF.cpp.o \
.\list.cpp.o \
.\node_cpp.cpp.o \
.\sloeber.ino.cpp.o 

CPP_DEPS += \
.\FiltroKalman.cpp.d \
.\LIDAR.cpp.d \
.\SAPPO.cpp.d \
.\UKF.cpp.d \
.\list.cpp.d \
.\node_cpp.cpp.d \
.\sloeber.ino.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
FiltroKalman.cpp.o: ..\FiltroKalman.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\Adafruit_VL53L0X-master\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

LIDAR.cpp.o: ..\LIDAR.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\Adafruit_VL53L0X-master\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

SAPPO.cpp.o: ..\SAPPO.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\Adafruit_VL53L0X-master\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

UKF.cpp.o: ..\UKF.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\Adafruit_VL53L0X-master\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

list.cpp.o: ..\list.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\Adafruit_VL53L0X-master\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

node_cpp.cpp.o: ..\node_cpp.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\Adafruit_VL53L0X-master\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"
	@echo 'Finished building: $<'
	@echo ' '

sloeber.ino.cpp.o: ..\sloeber.ino.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-g++" -c -g -Os -w -std=gnu++11 -fpermissive -fno-exceptions -ffunction-sections -fdata-sections -fno-threadsafe-statics -Wno-error=narrowing -MMD -flto -mmcu=atmega1280 -DF_CPU=16000000L -DARDUINO=10812 -DARDUINO_AVR_MEGA -DARDUINO_ARCH_AVR     -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\cores\arduino" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\variants\mega" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2\utility" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SoftwareSerial\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\Kalman\1.1.0" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\BasicLinearAlgebra\3.5.0" -I"C:\Users\antonio\Documents\Arduino\libraries\MeanFilterLib\src" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\libraries\RF24\1.4.2" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\VirtualWire" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\SPI\src" -I"C:\Users\antonio\Documents\Arduino\libraries\SoftwareServo" -I"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\hardware\avr\1.8.5\libraries\Wire\src" -I"C:\Users\antonio\Documents\Arduino\libraries\ServoTimer2" -I"C:\Users\antonio\Documents\Arduino\libraries\Adafruit_VL53L0X-master\src" -I"C:\Users\antonio\Documents\Arduino\libraries\vl53l0x" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"   -o "$@"

	@echo 'Finished building: $<'
	@echo ' '


