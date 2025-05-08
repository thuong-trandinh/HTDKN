/*
 * Frame.c
 *
 *  Created on: Apr 13, 2025
 *      Author: HP
 */


#include "Frame.h"


uint16_t Calculate_CRC16(uint8_t *data, uint16_t length) {
    uint16_t crc = 0xFFFF;
    for (uint16_t i = 0; i < length; i++) {
        crc ^= (uint16_t)(data[i] << 8);  // Sử dụng data[i] cho rõ ràng
        for (uint8_t j = 0; j < 8; j++) {
            if (crc & 0x8000)
                crc = (crc << 1) ^ 0x1021;
            else
                crc = crc << 1;
        }
    }
    return crc;
}

void packframe(uint8_t *outbuf, frame_t  *trans, uint8_t command){
	outbuf[0] = trans->start_bit;
	trans->command = command;
	outbuf[1] = trans->command;
	outbuf[2] = (uint8_t)(trans->length >> 8)&0xFF; // MSB
	outbuf[3] = (uint8_t)(trans->length & 0xFF);
	// Copy payload vào frame (nếu có)
	if ( trans->length > 0) {
	    memcpy(&outbuf[4], trans->payload, trans->length);
	}
	trans->CRC_16 = Calculate_CRC16(&outbuf[1],trans->length + 3); // temp ktr xiu nua xoa
	outbuf[trans->length + 4] = ((trans->CRC_16)>>8)&0xFF;
	outbuf[trans->length + 5] = trans->CRC_16&0xFF;
	outbuf[6 + trans->length] = trans->end;
}
void FloatToBytes(float value, uint8_t *out) {
    uint32_t asInt;
    /* Copy bit-pattern of float into 32-bit integer */
    value = value*3.30/4095;
    memcpy(&asInt, &value, sizeof(asInt));
    /* Extract bytes in big-endian order (MSB first) */
    out[0] = (uint8_t)((asInt >> 24) & 0xFF);
    out[1] = (uint8_t)((asInt >> 16) & 0xFF);
    out[2] = (uint8_t)((asInt >> 8) & 0xFF);
    out[3] = (uint8_t)(asInt & 0xFF);
}
void Decode_frame(uint8_t *outbuf, frame_t *trans){
	trans->start_bit = outbuf[0];
	trans->command = outbuf[1];
	trans->length = (outbuf[2]<<8)|outbuf[3];
	trans->CRC_16 = (outbuf[4 + trans->length]<<8)|outbuf[5 + trans->length];
	trans->end = outbuf[6 + trans->length];
	for(int i = 0;i < trans->length;i++){
		trans->payload[i] = outbuf[i + 4];
	}
}
void Decode_Payload_0x10(frame_t *trans,uint32_t *val){
	*val = (trans->payload[0]<<24)|(trans->payload[1]<<16)|(trans->payload[2]<<8)
			|trans ->payload[3];
}

