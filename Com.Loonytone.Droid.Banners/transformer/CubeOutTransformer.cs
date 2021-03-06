﻿/*
 * Copyright 2014 Toxic Bakery
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Android.Views;

namespace Com.Loonytone.Droid.Banners.transformer
{


	public class CubeOutTransformer : ABaseTransformer
	{

		protected override void onTransform(View view, float position)
		{
			view.PivotX = position < 0f ? view.Width : 0f;
			view.PivotY = view.Height * 0.5f;
			view.RotationY = 90f * position;
		}

		protected override bool PagingEnabled
		{
			get
			{
				return true;
			}
		}

	}

}