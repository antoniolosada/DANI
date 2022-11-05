################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ..\makefile.init

RM := rm -f

# All of the sources participating in the build are defined here
-include sources.mk
-include subdir.mk
-include libraries\vl53l0x\subdir.mk
-include libraries\Wire\src\utility\subdir.mk
-include libraries\Wire\src\subdir.mk
-include libraries\VirtualWire\subdir.mk
-include libraries\SoftwareServo\subdir.mk
-include libraries\SoftwareSerial\src\subdir.mk
-include libraries\ServoTimer2\subdir.mk
-include libraries\SPI\src\subdir.mk
-include libraries\RF24\subdir.mk
-include libraries\Kalman\subdir.mk
-include libraries\Adafruit_VL53L0X-master\src\platform\src\subdir.mk
-include libraries\Adafruit_VL53L0X-master\src\core\src\subdir.mk
-include libraries\Adafruit_VL53L0X-master\src\subdir.mk
-include core\core\subdir.mk
-include .metadata\.plugins\org.eclipse.cdt.make.core\subdir.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(INO_DEPS)),)
-include $(INO_DEPS)
endif
ifneq ($(strip $(PDE_DEPS)),)
-include $(PDE_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
endif

-include ..\makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
AR += \
C:\GOOGLE_DRIVE\GDRIVE\TONI\PROY\GITHUB\DANI\ECLIPSE_SLOEBER\DANI\DANI\Release\arduino.ar \

ELF += \
DANI.elf \

HEX += \
DANI.hex \


# All Target
all: DANI

# Tool invocations
DANI: $(HEX)
	@echo 'Building target: $@'
	@echo 'Printing size:'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-size" -A "C:\GOOGLE_DRIVE\GDRIVE\TONI\PROY\GITHUB\DANI\ECLIPSE_SLOEBER\DANI\DANI\Release/DANI.elf"
	@echo 'Finished building target: $@'
	@echo ' '

C:\GOOGLE_DRIVE\GDRIVE\TONI\PROY\GITHUB\DANI\ECLIPSE_SLOEBER\DANI\DANI\Release\arduino.ar: $(AR_OBJ)
	@echo 'Starting archiver'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-gcc-ar" rcs     C:\GOOGLE_DRIVE\GDRIVE\TONI\PROY\GITHUB\DANI\ECLIPSE_SLOEBER\DANI\DANI\Release/arduino.ar $(AR_OBJ)
	@echo 'Finished building: $@'
	@echo ' '

DANI.elf: $(LINK_OBJ) $(AR)
	@echo 'Starting combiner'
	"C:\PROGRAMAS\Sloeber\arduinoPlugin\packages\arduino\tools\avr-gcc\7.3.0-atmel3.6.1-arduino7/bin/avr-gcc" -w -Os -g -flto -fuse-linker-plugin -Wl,--gc-sections -mmcu=atmega1280   -o "C:\GOOGLE_DRIVE\GDRIVE\TONI\PROY\GITHUB\DANI\ECLIPSE_SLOEBER\DANI\DANI\Release/DANI.elf"   $(LINK_OBJ)    C:\GOOGLE_DRIVE\GDRIVE\TONI\PROY\GITHUB\DANI\ECLIPSE_SLOEBER\DANI\DANI\Release/arduino.ar  "-LC:\GOOGLE_DRIVE\GDRIVE\TONI\PROY\GITHUB\DANI\ECLIPSE_SLOEBER\DANI\DANI\Release" -lm
	@echo 'Finished building: $@'
	@echo ' '

DANI.hex: $(ELF)
	@echo 'Do all objcopy commands'
	${recipe.objcopy.eep.pattern}
	${recipe.objcopy.hex.pattern}
	@echo 'Finished building: $@'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(C_UPPER_DEPS)$(PDE_DEPS)$(C_DEPS)$(AR)$(CC_DEPS)$(AR_OBJ)$(C++_DEPS)$(LINK_OBJ)$(CXX_DEPS)$(ASM_DEPS)$(HEX)$(INO_DEPS)$(SIZEDUMMY)$(S_UPPER_DEPS)$(ELF)$(CPP_DEPS)
	-@echo ' '

.PHONY: all clean dependents

-include ..\makefile.targets
