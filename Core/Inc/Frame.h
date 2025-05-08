/*
 * Frame.h
 *
 *  Created on: Apr 13, 2025
 *      Author: HP
 */

#ifndef INC_FRAME_H_
#define INC_FRAME_H_
#include "stm32f4xx.h"
#include <string.h>
#include <stdlib.h>

typedef struct
{
	uint8_t start_bit; // 1byte = 0xAA
	uint8_t command;
	uint16_t length;
	uint8_t payload[5000];
	uint16_t CRC_16;
	uint8_t end ; // 0xAF
} frame_t;

uint16_t Calculate_CRC16(uint8_t *data, uint16_t length);
void packframe(uint8_t *outbuf, frame_t *trans, uint8_t command);
void FloatToBytes(float value, uint8_t *out);
void Decode_frame(uint8_t *outbuf, frame_t *trans);
void Decode_Payload_0x10(frame_t *trans,uint32_t *val);
#endif /* INC_FRAME_H_ */
