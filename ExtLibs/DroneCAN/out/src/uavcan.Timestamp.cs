


using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DroneCAN
{

    public partial class DroneCAN {
        static void encode_uavcan_Timestamp(uavcan_Timestamp msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx) {
            uint8_t[] buffer = new uint8_t[8];
            _encode_uavcan_Timestamp(buffer, msg, chunk_cb, ctx, true);
        }

        static uint32_t decode_uavcan_Timestamp(CanardRxTransfer transfer, uavcan_Timestamp msg) {
            uint32_t bit_ofs = 0;
            _decode_uavcan_Timestamp(transfer, ref bit_ofs, msg, true);
            return (bit_ofs+7)/8;
        }

        static void _encode_uavcan_Timestamp(uint8_t[] buffer, uavcan_Timestamp msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {






            memset(buffer,0,8);

            canardEncodeScalar(buffer, 0, 56, msg.usec);

            chunk_cb(buffer, 56, ctx);





        }

        static void _decode_uavcan_Timestamp(CanardRxTransfer transfer,ref uint32_t bit_ofs, uavcan_Timestamp msg, bool tao) {








            canardDecodeScalar(transfer, bit_ofs, 56, false, ref msg.usec);


            bit_ofs += 56;






        }

    }

}
