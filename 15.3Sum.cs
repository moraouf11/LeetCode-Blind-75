            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for(int i =0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i]) // that means we already computed for this number as the leading triplet
                    continue;
                int left = i + 1;
                int right = nums.Length - 1;
                while(left < right)
                {
                    if (nums[i] + nums[left] + nums[right] == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        while(left < right && nums[right] == nums[right - 1]) // to rule out repeated last numbers of the triplets
                        {
                            right--;
                        }
                        while (left < right && nums[left] == nums[left + 1])  // to rule out repeated second numbers of the triplets
                        {
                            left++;
                        }
                        right--;
                        left++;
                    }
                    else if (nums[i] + nums[left] + nums[right] > 0)
                        right--;
                    else
                        left++;
                    
                }
            }
            return result;
