/*
	Created by Carl Emil Carlsen.
	Copyright 2018-2020 Sixth Sensor.
	All rights reserved.
	http://sixthsensor.dk
*/

using System;

namespace OscSimpl
{
	[Serializable]
	struct OscArgInfo
	{
		public byte tagByte;
		public int byteCount;
		public int byteIndex;

		public static readonly OscArgInfo nullInfo = new OscArgInfo( OscConst.tagNullByte, 0 );
		public static readonly OscArgInfo impulseInfo = new OscArgInfo( OscConst.tagImpulseByte, 0 );
		public static readonly OscArgInfo boolTrueInfo = new OscArgInfo( OscConst.tagTrueByte, 0 );
		public static readonly OscArgInfo boolFalseInfo = new OscArgInfo( OscConst.tagFalseByte, 0 );
		public static readonly OscArgInfo floatInfo = new OscArgInfo( OscConst.tagFloatByte, 4 );
		public static readonly OscArgInfo intInfo = new OscArgInfo( OscConst.tagIntByte, 4 );
		public static readonly OscArgInfo charInfo = new OscArgInfo( OscConst.tagCharByte, 4 );
		public static readonly OscArgInfo colorInfo = new OscArgInfo( OscConst.tagColorByte, 4 );
		public static readonly OscArgInfo midiInfo = new OscArgInfo( OscConst.tagMidiByte, 4 );
		public static readonly OscArgInfo doubleInfo = new OscArgInfo( OscConst.tagDoubleByte, 8 );
		public static readonly OscArgInfo longInfo = new OscArgInfo( OscConst.tagLongByte, 8 );
		public static readonly OscArgInfo timeTagInfo = new OscArgInfo( OscConst.tagTimetagByte, 8 );
		public static readonly OscArgInfo eightByteBlobInfo = new OscArgInfo( OscConst.tagBlobByte, 4 + 8 ); // Blobs have a 4 byte size prefix.
		public static readonly OscArgInfo twelveByteBlobInfo = new OscArgInfo( OscConst.tagBlobByte, 4 + 12 );
		public static readonly OscArgInfo sixteenByteBlobInfo = new OscArgInfo( OscConst.tagBlobByte, 4 + 16 );
		public static readonly OscArgInfo sixtyfourByteBlobInfo = new OscArgInfo( OscConst.tagBlobByte, 4 + 64 );
		public static readonly OscArgInfo undefinedInfo = new OscArgInfo( OscConst.tagUnsupportedByte, 0 );


		public OscArgInfo( byte tagByte, int byteSize, int byteIndex = 0 )
		{
			this.tagByte = tagByte;
			this.byteCount = byteSize;
			this.byteIndex = byteIndex;
		}


		public override string ToString()
		{
			return "(" + ((char) tagByte) + ", " + byteCount + ")";
		}
	}
}